function removeFadeOut(el, speed) {
    var seconds = speed / 1000;
    el.style.transition = "opacity " + seconds + "s ease";

    el.style.opacity = 0;
    setTimeout(function () {
        el.parentNode.removeChild(el);
    }, speed);
}

setTimeout(function () {
    removeFadeOut(document.getElementById('message-box'), 3000);
}, 8000)
document.getElementById("message-box-close").addEventListener("click", function () {
    document.getElementById('message-box').remove();
})