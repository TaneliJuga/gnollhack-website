﻿angular.module("umbraco").controller("Our.Umbraco.ImagePositionController", function ($scope) {

    if ($scope.model.value == null) {
        $scope.model.value = 'FullWidth';
    }

    // could read positions from defaultConfig
    $scope.positions = [
        {
            Name: 'FullWidth'
        },
        {
            Name: 'Left'
        },
        {
            Name: 'Right'
        },
        {
            Name: 'Center'
        }
    ];
});