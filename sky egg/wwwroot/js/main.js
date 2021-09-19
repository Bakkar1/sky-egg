window.addEventListener('load', function () {
    let buttons = document.querySelectorAll('.goBackBtn');
    buttons.forEach(btn => {
        btn.onclick = function () {
            history.go(-1);
        }
    })
})