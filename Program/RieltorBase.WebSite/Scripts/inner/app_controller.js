'use strict';

// Контроллер для страницы объекта недвижимости
function appCntrl($scope, $http, $location, $routeParams) {

    // Считываем параметр id квартиры
    $scope.appId = $routeParams.appId;

    // Запрашиваем данные об объекте
    $http.get(GET_REALTY_OBJECT + $scope.appId).success(function (data) {
        $scope.app = data;
        console.log(data);
    });

    

    // print parameter in url
    console.log($location.path());
    console.log($location.search());

    // Колонки
    $scope.apptsColumns = [
		{
		    'column': 'Cost',
		    'readableName': 'Цена'
		},
		{
		    'column': 'Phone',
		    'readableName': 'Телефон'
		},
		{
		    'column': 'FirmName',
		    'readableName': 'Фирма '
		}
    ];
}
