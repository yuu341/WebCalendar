
angular
    .module('myApp.ctrl.calendar', [])
    .controller('CalendarCtrl', [
        '$scope',
        '$location',
        'CalendarService',
        function ($scope, $location, CalendarService) {

            $scope.calendarList = [];
            $scope.viewCalendar = function (id) {
                $location.path("/detail/" + id);
            };
            $scope.editCalendar = function (id) {
                $location.path("/edit/" + id);
            };
            $scope.deleteCalendar = function (id) {
                $location.path("/delete/" + id);
            };
            $scope.createCalendar = function () {
                $location.path("/create");
            };

            CalendarService
                .getCalendarList()
                .success(function (data, status, headers, config) {
                    $scope.calendarList = data.rows;
                });

            $scope.navigationManager.setListPage();

        }]);
