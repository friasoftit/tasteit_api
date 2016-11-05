(function () {
    "use strict";
    
    angular.module("TasteIt", ["lumx", "ngRoute", "ngResource"])
    .config(function ($routeProvider) {
        $routeProvider
        .when("/", {
            controller: "MainController",
            templateUrl: "/Pages/home.html"
        })
        .when("/establecimiento/new", {
            controller: "EstablecimientoController",
            templateUrl: "/Pages/establecimiento_form.html"
        })
    });

})();