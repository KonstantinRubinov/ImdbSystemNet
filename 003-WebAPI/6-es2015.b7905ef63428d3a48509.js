(window.webpackJsonp=window.webpackJsonp||[]).push([[6],{Sqah:function(e,t,i){"use strict";i.r(t),i.d(t,"ImdbModule",(function(){return b}));var o=i("tyNb"),s=i("Q9yQ"),n=i("pLZG"),r=i("fXoL"),a=i("pu2r"),d=i("PFzu"),c=i("IfdK"),g=i("iXKo"),u=i("ofXK"),l=i("gGFE");function v(e,t){1&e&&r["\u0275\u0275element"](0,"app-movie-card-vertical",2),2&e&&r["\u0275\u0275property"]("movie",t.$implicit)}const h=[{path:"",component:(()=>{class e{constructor(e,t,i,s,r){this.imdbService=e,this.redux=t,this.sessionService=i,this.logger=s,this.router=r,this.movies=[],this.allMoviesAllDataError="",this.place="imdb",this.navigationId=0,this.restoredStateId=0,r.events.pipe(Object(n.a)(e=>e instanceof o.b)).subscribe(e=>{console.group("NavigationStart Event"),this.logger.debug("navigation id: ",e.id),this.navigationId=e.id,this.logger.debug("route: ",e.url),this.logger.debug("trigger: ",e.navigationTrigger),e.restoredState&&(this.restoredStateId=e.restoredState.navigationId,this.logger.warn("restoring navigation id: ",e.restoredState.navigationId)),this.GetSession(e.navigationTrigger),console.groupEnd()})}GetSession(e){let t=[];"popstate"===e&&(t=this.sessionService.retrieveSession("ImdbComponent"),t&&t.length>0)&&(this.logger.debug("imdb to get: ",t),this.redux.dispatch({type:s.a.GetImdbMovies,payload:t}),this.movies=this.redux.getState().imdbMovies,this.logger.debug("GetSessionImdb: ",this.movies))}ngOnInit(){this.redux.dispatch({type:s.a.SetPlace,payload:this.place}),this.unsubscribe=this.redux.subscribe(()=>{this.movies=this.redux.getState().imdbMovies}),this.movies=this.redux.getState().imdbMovies}ngOnDestroy(){this.movies.length>0&&this.sessionService.storeSession("ImdbComponent",this.movies),this.unsubscribe()}}return e.\u0275fac=function(t){return new(t||e)(r["\u0275\u0275directiveInject"](a.a),r["\u0275\u0275directiveInject"](d.NgRedux),r["\u0275\u0275directiveInject"](c.a),r["\u0275\u0275directiveInject"](g.a),r["\u0275\u0275directiveInject"](o.c))},e.\u0275cmp=r["\u0275\u0275defineComponent"]({type:e,selectors:[["app-imdb"]],decls:2,vars:1,consts:[[1,"row","justify-content-md-center"],["class","col-md-auto center-block col-md-3",3,"movie",4,"ngFor","ngForOf"],[1,"col-md-auto","center-block","col-md-3",3,"movie"]],template:function(e,t){1&e&&(r["\u0275\u0275elementStart"](0,"div",0),r["\u0275\u0275template"](1,v,1,1,"app-movie-card-vertical",1),r["\u0275\u0275elementEnd"]()),2&e&&(r["\u0275\u0275advance"](1),r["\u0275\u0275property"]("ngForOf",t.movies))},directives:[u.h,l.a],styles:[""]}),e})()}];let m=(()=>{class e{}return e.\u0275mod=r["\u0275\u0275defineNgModule"]({type:e}),e.\u0275inj=r["\u0275\u0275defineInjector"]({factory:function(t){return new(t||e)},imports:[[o.e.forChild(h)],o.e]}),e})();var p=i("Bux+");let b=(()=>{class e{}return e.\u0275mod=r["\u0275\u0275defineNgModule"]({type:e}),e.\u0275inj=r["\u0275\u0275defineInjector"]({factory:function(t){return new(t||e)},imports:[[m,p.a]]}),e})()}}]);