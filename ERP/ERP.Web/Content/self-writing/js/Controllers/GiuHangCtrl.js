
app.controller('GiuHangHopLongCtrl', function ($scope, $http) {

    var macongty = $("#macongty").val();

    //=====Get data giữ hàng=================
    $scope.GetDataGiuHang= function()
    {
        $http.get(window.location.origin + '/api/Api_KhoGiuHang/GetAllListDataGiuKho/' + macongty)
         .then(function (response) {
             if (response.data) {
                 $scope.ListDataGiuKho = response.data;
             }
         }, function (error) {
             console.log(error);
         });
    }
    $scope.GetDataGiuHang();
    //----------------------------------------
 
    

   
});

