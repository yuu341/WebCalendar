
angular
    .module('myApp.service.calendar', [])
    .factory('CalendarService', [
        '$http',
        function ($http) {

            return {
                getCalendarList: function () {
                    return $http({
                        method: 'GET',
                        url: '/Cal/Calendars/List'
                    });
                },

                createCalendar: function (calendar) {
                    return $http({
                        method: 'POST',
                        url: '/Cal/Calendars/Create',
                        data: calendar
                    });
                },

                readCalendar: function (pid) {
                    return $http({
                        method: 'GET',
                        url: '/Cal/Calendars/Index/' + pid
                    });
                },

                updateCalendar: function (calendar) {
                    return $http({
                        method: 'PUT',
                        url: '/Cal/Calendars/Update/',
                        data: calendar
                    });
                },

                deleteCalendar: function (pid) {
                    return $http({
                        method: 'DELETE',
                        url: '/Cal/Calendars/Delete/' + pid
                    });
                }
            };
        }]);
