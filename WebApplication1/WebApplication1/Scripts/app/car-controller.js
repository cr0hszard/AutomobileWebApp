var app = angular.module("CarApp", []);

app.controller("CarCtrl", function ($scope, $http) {
    //URL of the CarControler
    var carsURL = "http://localhost:51634/api/Car/";
    $scope.cars;//CarData received
    
 //Getting data from CarControler.cs(~/api/Car)and saving it to $scope.cars
    $http.get(carsURL).then(function (response) {
        $scope.cars = response.data
    });

    
    
    
 });