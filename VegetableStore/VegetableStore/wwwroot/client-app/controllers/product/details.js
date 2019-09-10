var ProductDetailController = function () {
    this.initialize = function () {
        registerEvents();
    }

    function registerEvents() {
        $('#btnAddToCart').on('click', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            
            $.ajax({
                url: '/Cart/AddToCart',
                type: 'post',
                dataType: 'json',
                data: {
                    productId: id,
                    quantity: parseInt($('#txtQuantity').val()),
                    
                },
                success: function () {
                    tedu.notify('Product was added successful', 'success');
                    loadHeaderCart();
                },
                error: function (status) {
                    tedu.notify('Có lỗi xảy ra', 'error');
                    tedu.stopLoading();
                }
            });
        });
    }

    function loadHeaderCart() {
        $("#headerCart").load("/AjaxContent/HeaderCart");
    }
$('body').on('click', '.cart-fore', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            loadDetails(that);
        });
function loadDetails(that) {
        $.ajax({
            type: "GET",
            url: "/Product/GetById",
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
                $('.cart-plus-minus-box').val('1');
                $('#my_modal').modal('show');
                tedu.stopLoading();

            },
            error: function (status) {
                tedu.notify('Có lỗi xảy ra', 'error');
                tedu.stopLoading();
            }
        });
    }
}
$(document).ready(function () {
   
    $('.comments_advices li').click(function () {
        var a = document.getElementById("reviews")
        a.click();
    });
})