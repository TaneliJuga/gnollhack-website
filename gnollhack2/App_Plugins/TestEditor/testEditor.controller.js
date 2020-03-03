angular.module("umbraco")
    .controller("My.TestEditorController",
        function ($scope, entityResource) {
            //$scope.node = {
            //    name: "asd"
            //};
            $scope.node = "asd";
            console.log("node " + node);
            entityResource.getById(1147, "Document").then(function (ent) {
                $scope.node = "qwe";
                console.log("node " + node);
            });
            
        });