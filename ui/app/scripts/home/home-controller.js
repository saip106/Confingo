'use strict';

var LoginController = function ($scope, $route) {

    var that = this;
    $scope.$route = $route;

};

angular.module('confingoApp').controller('LoginController', LoginController);

