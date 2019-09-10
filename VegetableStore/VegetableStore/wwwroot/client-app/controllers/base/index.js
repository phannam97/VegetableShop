var BaseController = function () {
    this.initialize = function () {
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.cart-order', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var quantity = $('.quantity').val();
            $.ajax({
                url: '/Cart/AddToCart',
                type: 'post',
                data: {
                    productId: id,
                    quantity: quantity == null ? 1 : quantity
                },
                success: function (response) {
                    $('.quantity').val('1');
                    //tedu.notify(resources["AddCartOK"], 'success');
                    loadHeaderCart();
                }
            });
        });
        $('body').on('click', 'a.remove', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var status = "Cancelled";
            tedu.confirm('Bạn có muôn huy ?', function () {
                $.ajax({
                    type: "POST",
                    url: "/Admin/Bill/UpdateStatus",
                    data: { id, status },
                    dataType: "json",
                    beforeSend: function () {
                        tedu.startLoading();
                    },
                    success: function (response) {
                        tedu.notify('Huy thành công', 'success');
                        tedu.stopLoading();
                        location.reload();
                    },
                    error: function (status) {
                        tedu.notify('Has an error in delete progress', 'error');
                        tedu.stopLoading();
                    }
                });
            });
        });
        $('body').on('click', '.remove-cart', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            $.ajax({
                url: '/Cart/RemoveFromCart',
                type: 'post',
                data: {
                    productId: id
                },
                success: function (response) {
                   // tedu.notify(resources["RemoveCartOK"], 'success');
                    loadHeaderCart();
                }
            });
        });
    }

    function loadHeaderCart() {
        $("#headerCart").load("/AjaxContent/HeaderCart");
    }
   
}