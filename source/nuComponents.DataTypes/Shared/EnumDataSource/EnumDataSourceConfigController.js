﻿
angular
    .module("umbraco")
    .controller("nuComponents.DataTypes.Shared.EnumDataSource.EnumDataSourceConfigController",
    ['$scope', '$http', function ($scope, $http) {

        $scope.model.value = $scope.model.value || new Object();
        $scope.model.value.apiController = 'EnumDataSourceApi';

        $http.get('backoffice/nuComponents/EnumDataSourceApi/GetAssemblyNames').then(function (response) {

            $scope.assemblyNames = response.data;

            $scope.$watch('model.value.assemblyName', function () {

                $scope.enumNames = null;
                
                $http.get('backoffice/nuComponents/EnumDataSourceApi/GetEnumNames',
                    { params: { assemblyName: $scope.model.value.assemblyName } })
                    .then(function (response) {

                        $scope.enumNames = response.data;

                    });

            });

        });

    }]);

