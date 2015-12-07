'use strict';

angular
  .module('confingoApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'scripts/resource/resource-list.html',
        controller: 'ResourceListController',
        controllerAs: 'controller'
      })
      .when('/login', {
        templateUrl: 'scripts/login/login.html',
        controller: 'LoginController',
        controllerAs: 'loginController'
      })
      .when('/resources', {
        templateUrl: 'scripts/resource/resource-list.html',
        controller: 'ResourceListController',
        controllerAs: 'controller'
      })
      .otherwise({
        redirectTo: '/resources'
      });
  });
