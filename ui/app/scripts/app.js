'use strict';

angular
    .module('confingoApp', [
        'ngAnimate',
        'ngCookies',
        'ngResource',
        'ngRoute',
        'ngSanitize',
        'ngTouch',
        'ui.grid',
        'formly',
        'formlyBootstrap'
    ])
    .config(function ($routeProvider) {
        $routeProvider
            .when('/home', {
                templateUrl: 'scripts/home/home.html',
                controller: 'HomeController',
                controllerAs: 'homeController',
                activeTab: 'home'
            })
            .when('/login', {
                templateUrl: 'scripts/login/home.html',
                controller: 'LoginController',
                controllerAs: 'loginController',
                activeTab: 'login'
            })
            .when('/resources', {
                templateUrl: 'scripts/resource/resource-list.html',
                controller: 'ResourceListController',
                controllerAs: 'controller',
                activeTab: 'my-stuff'
            })
            .when('/add-resource', {
                templateUrl: 'scripts/resource/add-resource.html',
                controller: 'AddResourceController',
                controllerAs: 'controller',
                activeTab: 'add-resource'
            })
            .otherwise({
                redirectTo: '/home'
            });
    });
