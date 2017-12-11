$('.report-btn').click(function () {
    var result = confirm("Пожаловаться на отзыв?");
    var $this = $(this).parent();
    if (result) {
        var reviewId = $(this).data('review');
        var reason = prompt('Введите причину жалобы');
        if (reason.trim() !== '') {
            $.post({
                'url': '/Review/ReportOffensiveReview',
                'data': { reviewId: reviewId, reason: reason },
                'success': function () {
                    alert("Жалоба добавлена");
                    $this.css('opacity', '0.5');
                },
                'error': function (_, error) {
                    alert('error: ' + error)
                }
            });
        }
        else {
            return false;
        }
    }
    else {
        return false;
    }
});
