'use strict';

var AddResourceController = function ($scope, $route, ResourceService) {

    var that = this;
    $scope.$route = $route;

    that.resourceFields = [
        {
            key: 'name',
            type: 'input',
            templateOptions: {
                type: 'text',
                label: 'Name',
                placeholder: 'Enter name',
                required: true
            }
        },
        {
            key: 'description',
            type: 'textarea',
            templateOptions: {
                type: 'text',
                label: 'Description',
                placeholder: 'Enter description',
                required: false
            }
        }
    ];

    that.add = function add(resource) {
        resource.userId = 1;
        ResourceService.add(resource).then(function success() {
                toastr.success('added !!!');
            },
            function error() {
                toastr.error('could not add !!!');
            });

    };
};

angular.module('confingoApp').controller('AddResourceController', AddResourceController);
