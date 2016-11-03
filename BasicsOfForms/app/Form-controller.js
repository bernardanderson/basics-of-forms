"use strict";

app.controller("formcontroller", function ($scope, $http) {

    $scope.formSubmit = function (sentUserValues) {
        $http({
            method: 'POST',
            url: '/api/AngularApi',
            data: sentUserValues
        }).then(function successCallback(response) {
            console.log("Http Reponse Code: " + response.status);
            console.log("**POST Successful**");
        }, function errorCallback(response) {
            console.log("Http Reponse Code: " + response.status);
            console.log("**Unsuccessful POST Attempt**");
        });

    }

});