(function () {
    "use strict";

    angular.module("app-trips")
        .controller("tripsController", tripsController);

    function tripsController($http) {
        var vm = this;

        vm.trips = [];

        vm.newTrip = {};

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/trips")
            .then(function (reponse) {
                angular.copy(reponse.data, vm.trips);
            }, function (error) {
                vm.errorMessage = "Failure to load data: " + error;
            })
        .finally(function () {
            vm.isBusy = false;
        });

        vm.addTrip = function () {
            vm.isBusy = true;

            $http.post("/api/trips", vm.newTrip)
             .then(function (reponse) {
                 vm.trips.push(reponse.data);
                 vm.newTrip = {};
             }, function () {
                 vm.errorMessage = "Failure to save new trip";
             })
        .finally(function () {
            vm.isBusy = false;
        });
        };
    }
})();