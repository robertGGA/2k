
$('info').click(function (e) {
    e.preventDefault();

    $.ajax({
        url: '/about',
        type: GET,
        data: String,
        success: function () {
            let root = document.getElementById('root');
            root.innerHTML('<p> 1 </p>');
            alert('dwr');
        }, error: function () {
            let root = document.getElementById('root');
            root.innerHTML('<p> 1 </p>');
            alert('failed');
        }
    });
});