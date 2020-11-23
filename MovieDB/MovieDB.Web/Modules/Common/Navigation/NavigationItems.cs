using Serenity.Navigation;
using Administration = MovieDB.Administration.Pages;
using DefaultDB = MovieDB.Default.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]
[assembly: NavigationMenu(2000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(2100, "Movie Database/Movie", typeof(DefaultDB.MovieController), icon: "fa-video-camera")]