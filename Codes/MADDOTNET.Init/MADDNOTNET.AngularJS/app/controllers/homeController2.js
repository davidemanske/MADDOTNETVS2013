(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'homeController2';

    // Define the controller on the module.
    // Inject the dependencies. 
    // Point to the controller definition function.
    angular.module('myApp').controller(controllerId,
        ['$scope', homeController2]);

    function homeController2($scope) {
        // Bindable properties and functions are placed on vm.
        $scope.title = 'homeController2';
        $scope.activate = activate;

        function activate() {
        }

        //#region Internal Methods        

        //#endregion
    }
})();
