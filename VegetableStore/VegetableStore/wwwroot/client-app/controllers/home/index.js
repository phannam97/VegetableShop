var HomeController = function () {
    this.initialize = function () {
     
    }
}
$('body').on('click', '.cart-fore', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            loadDetails(that);
        });
function loadDetails(that) {
        $.ajax({
            type: "GET",
            url: "/Home/GetById",
            data: { id: that },
            dataType: "json",
            beforeSend: function () {
                tedu.startLoading();
            },
            success: function (response) {
                var data = response;
                $('#Pname').text(data.Name);
                $('#imgeoneM').attr('src', data.Image);
                $('.cart-order').data('id', data.Id);
                $('.cart_description').text(data.Description);
                var price = "$" + data.Price;
                $('.regular_price').text(price);
                $('.quantity').val('1');
                $('#my_modal').modal('show');
                tedu.stopLoading();

            },
            error: function (status) {
                tedu.notify('Có lỗi xảy ra', 'error');
                tedu.stopLoading();
            }
        });
    }