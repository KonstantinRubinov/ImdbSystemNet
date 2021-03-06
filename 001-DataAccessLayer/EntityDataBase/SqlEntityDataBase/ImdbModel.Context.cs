//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImdbSystem.EntityDataBase.SqlEntityDataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Data.Entity.Validation;
    using System.Diagnostics;

    public partial class ImdbFavoritesEntities : DbContext
    {
        public ImdbFavoritesEntities() : base("name=ImdbFavoritesEntities")
        {
        }

		public override int SaveChanges()
		{
			try
			{
				return base.SaveChanges();
			}
			catch (DbEntityValidationException ex)
			{
				// Retrieve the error messages as a list of strings.
				var errorMessages = ex.EntityValidationErrors
						.SelectMany(x => x.ValidationErrors)
						.Select(x => x.ErrorMessage);

				// Join the list to a single string.
				var fullErrorMessage = string.Join("; ", errorMessages);
				Debug.WriteLine("DbEntityValidationException: " + errorMessages);
				throw new DbEntityValidationException(fullErrorMessage, ex.EntityValidationErrors);
			}
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MOVIEEXTEND> MOVIEEXTENDS { get; set; }
        public virtual DbSet<MOVy> MOVIES { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
    
        public virtual ObjectResult<AddExtendedMovie_Result> AddExtendedMovie(string movieImdbID, string movieTitle, string moviePoster, Nullable<int> movieYear, string userID, string moviePlot, string movieUrl, string movieRated, Nullable<float> movieImdbRating, Nullable<bool> movieSeen)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var movieTitleParameter = movieTitle != null ?
                new ObjectParameter("movieTitle", movieTitle) :
                new ObjectParameter("movieTitle", typeof(string));
    
            var moviePosterParameter = moviePoster != null ?
                new ObjectParameter("moviePoster", moviePoster) :
                new ObjectParameter("moviePoster", typeof(string));
    
            var movieYearParameter = movieYear.HasValue ?
                new ObjectParameter("movieYear", movieYear) :
                new ObjectParameter("movieYear", typeof(int));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            var moviePlotParameter = moviePlot != null ?
                new ObjectParameter("moviePlot", moviePlot) :
                new ObjectParameter("moviePlot", typeof(string));
    
            var movieUrlParameter = movieUrl != null ?
                new ObjectParameter("movieUrl", movieUrl) :
                new ObjectParameter("movieUrl", typeof(string));
    
            var movieRatedParameter = movieRated != null ?
                new ObjectParameter("movieRated", movieRated) :
                new ObjectParameter("movieRated", typeof(string));
    
            var movieImdbRatingParameter = movieImdbRating.HasValue ?
                new ObjectParameter("movieImdbRating", movieImdbRating) :
                new ObjectParameter("movieImdbRating", typeof(float));
    
            var movieSeenParameter = movieSeen.HasValue ?
                new ObjectParameter("movieSeen", movieSeen) :
                new ObjectParameter("movieSeen", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddExtendedMovie_Result>("AddExtendedMovie", movieImdbIDParameter, movieTitleParameter, moviePosterParameter, movieYearParameter, userIDParameter, moviePlotParameter, movieUrlParameter, movieRatedParameter, movieImdbRatingParameter, movieSeenParameter);
        }
    
        public virtual ObjectResult<AddMovie_Result> AddMovie(string movieImdbID, string movieTitle, string moviePoster, Nullable<int> movieYear, string userID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var movieTitleParameter = movieTitle != null ?
                new ObjectParameter("movieTitle", movieTitle) :
                new ObjectParameter("movieTitle", typeof(string));
    
            var moviePosterParameter = moviePoster != null ?
                new ObjectParameter("moviePoster", moviePoster) :
                new ObjectParameter("moviePoster", typeof(string));
    
            var movieYearParameter = movieYear.HasValue ?
                new ObjectParameter("movieYear", movieYear) :
                new ObjectParameter("movieYear", typeof(int));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddMovie_Result>("AddMovie", movieImdbIDParameter, movieTitleParameter, moviePosterParameter, movieYearParameter, userIDParameter);
        }
    
        public virtual ObjectResult<AddUser_Result> AddUser(string userID, string userFirstName, string userLastName, string userNickName, Nullable<System.DateTime> userBirthDate, string userGender, string userEmail, string userPassword, string userPicture, string userImdbPass)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            var userFirstNameParameter = userFirstName != null ?
                new ObjectParameter("userFirstName", userFirstName) :
                new ObjectParameter("userFirstName", typeof(string));
    
            var userLastNameParameter = userLastName != null ?
                new ObjectParameter("userLastName", userLastName) :
                new ObjectParameter("userLastName", typeof(string));
    
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            var userBirthDateParameter = userBirthDate.HasValue ?
                new ObjectParameter("userBirthDate", userBirthDate) :
                new ObjectParameter("userBirthDate", typeof(System.DateTime));
    
            var userGenderParameter = userGender != null ?
                new ObjectParameter("userGender", userGender) :
                new ObjectParameter("userGender", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            var userPictureParameter = userPicture != null ?
                new ObjectParameter("userPicture", userPicture) :
                new ObjectParameter("userPicture", typeof(string));
    
            var userImdbPassParameter = userImdbPass != null ?
                new ObjectParameter("userImdbPass", userImdbPass) :
                new ObjectParameter("userImdbPass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AddUser_Result>("AddUser", userIDParameter, userFirstNameParameter, userLastNameParameter, userNickNameParameter, userBirthDateParameter, userGenderParameter, userEmailParameter, userPasswordParameter, userPictureParameter, userImdbPassParameter);
        }
    
        public virtual int DeleteExtendedMovie(string movieImdbID, string userID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteExtendedMovie", movieImdbIDParameter, userIDParameter);
        }
    
        public virtual int DeleteMovie(string movieImdbID, string userID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMovie", movieImdbIDParameter, userIDParameter);
        }
    
        public virtual int DeleteUser(string userID)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", userIDParameter);
        }
    
        public virtual ObjectResult<GetAllExtendedMovies_Result> GetAllExtendedMovies(string userID)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllExtendedMovies_Result>("GetAllExtendedMovies", userIDParameter);
        }
    
        public virtual ObjectResult<GetAllMovies_Result> GetAllMovies(string userID)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMovies_Result>("GetAllMovies", userIDParameter);
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual ObjectResult<GetById_Result> GetById(string movieImdbID, string userID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetById_Result>("GetById", movieImdbIDParameter, userIDParameter);
        }
    
        public virtual ObjectResult<GetByIdExtendedMovies_Result> GetByIdExtendedMovies(string movieImdbID, string userID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdExtendedMovies_Result>("GetByIdExtendedMovies", movieImdbIDParameter, userIDParameter);
        }
    
        public virtual ObjectResult<GetByTitle_Result> GetByTitle(string movieTitle, string userID)
        {
            var movieTitleParameter = movieTitle != null ?
                new ObjectParameter("movieTitle", movieTitle) :
                new ObjectParameter("movieTitle", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByTitle_Result>("GetByTitle", movieTitleParameter, userIDParameter);
        }
    
        public virtual ObjectResult<GetByTitleExtendedMovies_Result> GetByTitleExtendedMovies(string movieTitle, string userID)
        {
            var movieTitleParameter = movieTitle != null ?
                new ObjectParameter("movieTitle", movieTitle) :
                new ObjectParameter("movieTitle", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByTitleExtendedMovies_Result>("GetByTitleExtendedMovies", movieTitleParameter, userIDParameter);
        }
    
        public virtual ObjectResult<GetByWord_Result> GetByWord(string word, string userID)
        {
            var wordParameter = word != null ?
                new ObjectParameter("word", word) :
                new ObjectParameter("word", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByWord_Result>("GetByWord", wordParameter, userIDParameter);
        }
    
        public virtual ObjectResult<GetByWordExtendedMovies_Result> GetByWordExtendedMovies(string word, string userID)
        {
            var wordParameter = word != null ?
                new ObjectParameter("word", word) :
                new ObjectParameter("word", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByWordExtendedMovies_Result>("GetByWordExtendedMovies", wordParameter, userIDParameter);
        }
    
        public virtual ObjectResult<GetOneUserById_Result> GetOneUserById(string userID)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOneUserById_Result>("GetOneUserById", userIDParameter);
        }
    
        public virtual ObjectResult<GetOneUserByName_Result> GetOneUserByName(string userNickName)
        {
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOneUserByName_Result>("GetOneUserByName", userNickNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> IsNameTaken(string userNickName)
        {
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("IsNameTaken", userNickNameParameter);
        }
    
        public virtual ObjectResult<ReturnImdbPassByNamePassword_Result> ReturnImdbPassByNamePassword(string userNickName, string userPassword)
        {
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReturnImdbPassByNamePassword_Result>("ReturnImdbPassByNamePassword", userNickNameParameter, userPasswordParameter);
        }
    
        public virtual ObjectResult<ReturnUserByNameLogin_Result> ReturnUserByNameLogin(string userNickName, string userPassword)
        {
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReturnUserByNameLogin_Result>("ReturnUserByNameLogin", userNickNameParameter, userPasswordParameter);
        }
    
        public virtual ObjectResult<ReturnUserByNamePassword_Result> ReturnUserByNamePassword(string userNickName, string userPassword)
        {
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReturnUserByNamePassword_Result>("ReturnUserByNamePassword", userNickNameParameter, userPasswordParameter);
        }
    
        public virtual ObjectResult<string> ReturnUserIdByImdbPass(string movieImdbID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ReturnUserIdByImdbPass", movieImdbIDParameter);
        }
    
        public virtual ObjectResult<string> ReturnUserIdByUserPass(string userPassword)
        {
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ReturnUserIdByUserPass", userPasswordParameter);
        }
    
        public virtual ObjectResult<UpdateExtendedMovie_Result> UpdateExtendedMovie(string movieImdbID, string movieTitle, string moviePoster, Nullable<int> movieYear, string userID, string moviePlot, string movieUrl, string movieRated, Nullable<float> movieImdbRating, Nullable<bool> movieSeen)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var movieTitleParameter = movieTitle != null ?
                new ObjectParameter("movieTitle", movieTitle) :
                new ObjectParameter("movieTitle", typeof(string));
    
            var moviePosterParameter = moviePoster != null ?
                new ObjectParameter("moviePoster", moviePoster) :
                new ObjectParameter("moviePoster", typeof(string));
    
            var movieYearParameter = movieYear.HasValue ?
                new ObjectParameter("movieYear", movieYear) :
                new ObjectParameter("movieYear", typeof(int));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            var moviePlotParameter = moviePlot != null ?
                new ObjectParameter("moviePlot", moviePlot) :
                new ObjectParameter("moviePlot", typeof(string));
    
            var movieUrlParameter = movieUrl != null ?
                new ObjectParameter("movieUrl", movieUrl) :
                new ObjectParameter("movieUrl", typeof(string));
    
            var movieRatedParameter = movieRated != null ?
                new ObjectParameter("movieRated", movieRated) :
                new ObjectParameter("movieRated", typeof(string));
    
            var movieImdbRatingParameter = movieImdbRating.HasValue ?
                new ObjectParameter("movieImdbRating", movieImdbRating) :
                new ObjectParameter("movieImdbRating", typeof(float));
    
            var movieSeenParameter = movieSeen.HasValue ?
                new ObjectParameter("movieSeen", movieSeen) :
                new ObjectParameter("movieSeen", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateExtendedMovie_Result>("UpdateExtendedMovie", movieImdbIDParameter, movieTitleParameter, moviePosterParameter, movieYearParameter, userIDParameter, moviePlotParameter, movieUrlParameter, movieRatedParameter, movieImdbRatingParameter, movieSeenParameter);
        }
    
        public virtual ObjectResult<UpdateMovie_Result> UpdateMovie(string movieImdbID, string movieTitle, string moviePoster, Nullable<int> movieYear, string userID)
        {
            var movieImdbIDParameter = movieImdbID != null ?
                new ObjectParameter("movieImdbID", movieImdbID) :
                new ObjectParameter("movieImdbID", typeof(string));
    
            var movieTitleParameter = movieTitle != null ?
                new ObjectParameter("movieTitle", movieTitle) :
                new ObjectParameter("movieTitle", typeof(string));
    
            var moviePosterParameter = moviePoster != null ?
                new ObjectParameter("moviePoster", moviePoster) :
                new ObjectParameter("moviePoster", typeof(string));
    
            var movieYearParameter = movieYear.HasValue ?
                new ObjectParameter("movieYear", movieYear) :
                new ObjectParameter("movieYear", typeof(int));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateMovie_Result>("UpdateMovie", movieImdbIDParameter, movieTitleParameter, moviePosterParameter, movieYearParameter, userIDParameter);
        }
    
        public virtual ObjectResult<UpdateUser_Result> UpdateUser(string userID, string userFirstName, string userLastName, string userNickName, Nullable<System.DateTime> userBirthDate, string userGender, string userEmail, string userPassword, string userPicture, string userImdbPass)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            var userFirstNameParameter = userFirstName != null ?
                new ObjectParameter("userFirstName", userFirstName) :
                new ObjectParameter("userFirstName", typeof(string));
    
            var userLastNameParameter = userLastName != null ?
                new ObjectParameter("userLastName", userLastName) :
                new ObjectParameter("userLastName", typeof(string));
    
            var userNickNameParameter = userNickName != null ?
                new ObjectParameter("userNickName", userNickName) :
                new ObjectParameter("userNickName", typeof(string));
    
            var userBirthDateParameter = userBirthDate.HasValue ?
                new ObjectParameter("userBirthDate", userBirthDate) :
                new ObjectParameter("userBirthDate", typeof(System.DateTime));
    
            var userGenderParameter = userGender != null ?
                new ObjectParameter("userGender", userGender) :
                new ObjectParameter("userGender", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            var userPictureParameter = userPicture != null ?
                new ObjectParameter("userPicture", userPicture) :
                new ObjectParameter("userPicture", typeof(string));
    
            var userImdbPassParameter = userImdbPass != null ?
                new ObjectParameter("userImdbPass", userImdbPass) :
                new ObjectParameter("userImdbPass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateUser_Result>("UpdateUser", userIDParameter, userFirstNameParameter, userLastNameParameter, userNickNameParameter, userBirthDateParameter, userGenderParameter, userEmailParameter, userPasswordParameter, userPictureParameter, userImdbPassParameter);
        }
    
        public virtual ObjectResult<UploadUserImage_Result> UploadUserImage(string userID, string userPicture)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            var userPictureParameter = userPicture != null ?
                new ObjectParameter("userPicture", userPicture) :
                new ObjectParameter("userPicture", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UploadUserImage_Result>("UploadUserImage", userIDParameter, userPictureParameter);
        }
    }
}
