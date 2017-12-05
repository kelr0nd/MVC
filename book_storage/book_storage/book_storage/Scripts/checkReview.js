function replacer(str, offset, s) {
    var res = ""
    for (var j = 1; j < str.length; j++) {
        res += "*";
    }
    return res;
}

$('form').on('submit', function () {
    var library = ["отстой", "отвратительно", "ужасно"];
    var authorName = $('#Name').val();
    var textReview = $('#Review').val();
    for (var i = 0; i < library.length; i++) {
        if (textReview.indexOf(library[i]) !== -1) {         
            var result = confirm("Недопустимые выражения. Заменить на ***?")
            if(result){
                var reg = new RegExp(library.join('|'), "gi");          
                $('#Review').val(textReview.replace(reg, replacer));
            }
            else{
                return false;
            }
        }
    }
    return true;
});