angular
    .module('confingoApp')
    .factory('ResourceService', function ($http) {

        var add = function add(resource) {
            return $http.post('http://localhost:53562/api/resources', resource);
        };

        return {
            add : add
        };
    })