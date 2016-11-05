angular.module("TasteIt")
.controller("MainController", function ($scope, $resource) {

}).controller("EstablecimientoController", function ($scope, $resource, $http) {


    $scope.ajax = {
        selected: 'Inception',
        list: [],
        update: function (newFilter) {
            if (newFilter) {
                $scope.ajax.loading = true;
                $http.get('http://www.omdbapi.com/?s=' + escape(newFilter)).
                    success(function (data) {
                        $scope.ajax.list = data.Search;
                        $scope.ajax.loading = false;
                    }).
                    error(function () {
                        $scope.ajax.loading = false;
                    });
            }
            else {
                $scope.ajax.list = false;
            }
        },
        toModel: function (data, callback) {
            if (data) {
                callback(data.Title);
            }
            else {
                callback();
            }
        },
        toSelection: function (data, callback) {
            if (data) {
                $http.get('http://www.omdbapi.com/?s=' + escape(data)).
                    success(function (response) {
                        callback(response.Search[0]);
                    }).
                    error(function () {
                        callback();
                    });
            }
            else {
                callback();
            }
        },
        loading: false
    };
});