app.controller('DomainsController', ['$scope', '$http', function ($scope, $http) {    
    $scope.GetDomains = function () {
        $scope.ListDomains = '';

        //Find Domains
        $http.get('/Json/domains.json')
            .then(function (response) {
                $http.post('api/DomainApi/SendDomains', response.data).then(function (outerresponse) {
                    $scope.ListDomains = "Encontrou a empresa { " + outerresponse.data.Name + " } no domínio: { " + outerresponse.data.Mail + " } ";
                });
            });
    };
}]);