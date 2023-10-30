window.addEventListener('scroll', function() {
    var button = document.getElementById('back-to-top');
    if (window.pageYOffset > 100) {
      button.style.display = 'block';
    } else {
      button.style.display = 'none';
    }
  });
  