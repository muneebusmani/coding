const image = document.querySelector('.big-olink');
const breakpoint = 1099.98;

function replaceImage() {
  if (window.innerWidth < breakpoint) { 
    image.src = 'images/5-benefits/olink.svg';
    image.alt = 'Small-olink';
    image.classList = 'align-self-center'
  } else {
    image.src = 'images/5-benefits/Frame 1.svg';
    image.alt = 'big-olink';
    image.classList = 'big-olink align-self-center'
  }
}
window.addEventListener('load', replaceImage);
window.addEventListener('resize', replaceImage);


