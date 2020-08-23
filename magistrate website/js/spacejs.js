function scenarioshowspace() {
  var hid = document.getElementsByClassName("scenarioshow-space");
  // Emulates jQuery $(element).is(':hidden');
  if (hid[0].offsetWidth > 0 && hid[0].offsetHeight > 0) {
    hid[0].style.visibility = "visible";
    var statsdel = document.getElementsByClassName("statsshow-space");
    statsdel[0].style.visibility = "hidden";
  }
}

function scendelspace() {
  var scendel = document.getElementsByClassName("scenarioshow-space");
  scendel[0].style.visibility = "hidden";
}

function statsdelspace() {
  var statsdel = document.getElementsByClassName("statsshow-space");
  statsdel[0].style.visibility = "hidden";
}

function ansdelspace() {
  var ansdel = document.getElementsByClassName("answersshow-space");
  ansdel[0].style.visibility = "hidden";
}

function bugsdelspace() {
  var bugsdel = document.getElementsByClassName("bugsshow-space");
  bugsdel[0].style.visibility = "hidden";
}

function creddelspace() {
  var creddel = document.getElementsByClassName("creditsshow-space");
  creddel[0].style.visibility = "hidden";
}

function statsshowspace() {
  var statsshow = document.getElementsByClassName("statsshow-space");
  // Emulates jQuery $(element).is(':hidden');
  if (statsshow[0].offsetWidth > 0 && statsshow[0].offsetHeight > 0) {
    statsshow[0].style.visibility = "visible";
  }
}

function answersshowspace() {
  var answersshow = document.getElementsByClassName("answersshow-space");
  // Emulates jQuery $(element).is(':hidden');
  if (answersshow[0].offsetWidth > 0 && answersshow[0].offsetHeight > 0) {
    answersshow[0].style.visibility = "visible";
  }
}

function bugsshowspace() {
  var bugsshow = document.getElementsByClassName("bugsshow-space");
  // Emulates jQuery $(element).is(':hidden');
  if (bugsshow[0].offsetWidth > 0 && bugsshow[0].offsetHeight > 0) {
    bugsshow[0].style.visibility = "visible";
  }
}

function creditsshowspace() {
  var creditsshow = document.getElementsByClassName("creditsshow-space");
  // Emulates jQuery $(element).is(':hidden');
  if (creditsshow[0].offsetWidth > 0 && creditsshow[0].offsetHeight > 0) {
    creditsshow[0].style.visibility = "visible";
  }
}
