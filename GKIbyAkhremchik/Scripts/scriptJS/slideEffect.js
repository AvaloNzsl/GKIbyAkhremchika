var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("slides");
    var line = document.getElementsByClassName("lineSlide");
    for (i = 0; i < slides.length; i++) {
       slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex> slides.length) {slideIndex = 1}
    for (i = 0; i < line.length; i++) {
        line[i].className = line[i].className.replace(" activeSlide", "");
    }
    slides[slideIndex - 1].style.display = "block";
    line[slideIndex - 1].className += " activeSlide";
    setTimeout(showSlides, 2000); // Change image every 2 seconds
}