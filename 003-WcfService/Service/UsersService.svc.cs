using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;

namespace ImdbSystem
{
	public class UsersService : IUsersService
	{
		private IUsersRepository usersRepository;
		public UsersService()
		{
			if (GlobalVariable.logicType == 0)
				usersRepository = new EntityUsersManager();
			else if (GlobalVariable.logicType == 1)
				usersRepository = new SqlUsersManager();
			else if (GlobalVariable.logicType == 2)
				usersRepository = new MySqlUsersManager();
			else
				usersRepository = new MongoUsersManager();
		}

		public HttpResponseMessage GetAllUsers()
		{
			try { 
				HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.OK)
				{
					Content = new StringContent(JsonConvert.SerializeObject(usersRepository.GetAllUsers()))
				};
				return hrm;
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(errors.ToString())
				};
				return hr;
			}
		}

		public HttpResponseMessage GetOneUser(string getByID)
		{
			try
			{
				HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.OK)
				{
					Content = new StringContent(JsonConvert.SerializeObject(usersRepository.GetOneUserById(getByID)))
				};
				return hrm;
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(errors.ToString())
				};
				return hr;
			}
		}

		public HttpResponseMessage ReturnUserByNamePassword(LoginModel loginModel)
		{
			try
			{
				HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.Created)
				{
					Content = new StringContent(JsonConvert.SerializeObject(usersRepository.ReturnUserByNamePassword(loginModel)))
				};
				return hrm;
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(errors.ToString())
				};
				return hr;
			}
		}

		public HttpResponseMessage AddUser(UserModel userModel)
		{
			try
			{
				byte[] bytes = Convert.FromBase64String(userModel.userImage);
				string[] extensions = userModel.userPicture.Split('.');
				string extension = extensions[extensions.Length - 1];
				string fileName = Guid.NewGuid().ToString();
				string filePath = HttpContext.Current.Server.MapPath("~/assets/images/users/" + fileName + "." + extension);
				using (FileStream binaryFileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
				{
					binaryFileStream.Write(bytes, 0, bytes.Length);
					userModel.userPicture = fileName + "." + extension;
				}
				userModel.userImage = string.Empty;
				UserModel addedUser = usersRepository.AddUser(userModel);


				HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.Created)
				{
					Content = new StringContent(JsonConvert.SerializeObject(addedUser))
				};

				return hrm;
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(errors.ToString())
				};
				return hr;
			}
		}

		public HttpResponseMessage UpdateUser(string updateById, UserModel userModel)
		{
			try
			{
				userModel.userID = updateById;
				UserModel updatedUser = usersRepository.UpdateUser(userModel);

				HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.OK)
				{
					Content = new StringContent(JsonConvert.SerializeObject(updatedUser))
				};
				return hrm;
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(errors.ToString())
				};
				return hr;
			}
		}

		public HttpResponseMessage DeleteUser(string deleteById)
		{
			try
			{
				int i = usersRepository.DeleteUser(deleteById);

				if (i > 0)
				{
					HttpResponseMessage hrm = new HttpResponseMessage(HttpStatusCode.NoContent)
					{
					};
					return hrm;
				}
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
				};
				return hr;
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				HttpResponseMessage hr = new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent(errors.ToString())
				};
				return hr;
			}
		}

		
	}
}
