'use strict';

var ResourceListController = function () {
  var that = this;

  that.resources = [
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
};

angular.module('confingoApp').controller('ResourceListController', ResourceListController);
