'use strict';

var ResourceListController = function ($scope, $route, $location) {

    var that = this;
    $scope.$route = $route;

    var resources = [
        {
            id: 1,
            uniqueId: 'abcdefg',
            name: 'Amine\'s Wallet',
            description: 'This is where Amine keeps all his money'
        },
        {
            id: 2,
            uniqueId: 'hijklm',
            name: 'Amine\'s Car',
            description: 'This is what Amine drives'
        }
    ];

    that.resourcesGridOptions = {
        data: resources,
        columnDefs: [{
                field: 'uniqueId',
                displayName: 'Id',
                width: '15%'
            },
            {
                field: 'name',
                displayName: 'Name',
                width: '30%'
            },
            {
                field: 'description',
                displayName: 'Description',
                width: '*'
            }
        ]
    };

    that.addNewResource = function addNewResource() {
        $location.path( "/add-resource" );
    };
};

angular.module('confingoApp').controller('ResourceListController', ResourceListController);
