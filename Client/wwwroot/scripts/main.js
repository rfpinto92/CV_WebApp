// Animations
AOS.init({
  anchorPlacement: 'top-left',
  duration: 1000
});

window.initCarousel = () => {
    const elem = document.querySelector('.main-carousel');
    if (!elem) return;

    new Flickity(elem, {
        cellAlign: 'left',
        contain: true,
        autoPlay: 5000,
        prevNextButtons: false
    });
};

window.scrollToSection = (id) => {
    const el = document.getElementById(id);
    if (el) {
        el.scrollIntoView({ behavior: "smooth" });
    }
};

// Add your javascript here
