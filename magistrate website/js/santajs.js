function scenarioshow() {
  var hid = document.getElementsByClassName("scenarioshow");
  // Emulates jQuery $(element).is(':hidden');
  if (hid[0].offsetWidth > 0 && hid[0].offsetHeight > 0) {
    hid[0].style.visibility = "visible";
    var statsdel = document.getElementsByClassName("statsshow");
    statsdel[0].style.visibility = "hidden";
  }
}

function scendel() {
  var scendel = document.getElementsByClassName("scenarioshow");
  scendel[0].style.visibility = "hidden";
}

function statsdel() {
  var statsdel = document.getElementsByClassName("statsshow");
  statsdel[0].style.visibility = "hidden";
}

function ansdel() {
  var ansdel = document.getElementsByClassName("answersshow");
  ansdel[0].style.visibility = "hidden";
}

function bugsdel() {
  var bugsdel = document.getElementsByClassName("bugsshow");
  bugsdel[0].style.visibility = "hidden";
}

function creddel() {
  var creddel = document.getElementsByClassName("creditsshow");
  creddel[0].style.visibility = "hidden";
}

function statsshow() {
  var statsshow = document.getElementsByClassName("statsshow");
  // Emulates jQuery $(element).is(':hidden');
  if (statsshow[0].offsetWidth > 0 && statsshow[0].offsetHeight > 0) {
    statsshow[0].style.visibility = "visible";
  }
}

function answersshow() {
  var answersshow = document.getElementsByClassName("answersshow");
  // Emulates jQuery $(element).is(':hidden');
  if (answersshow[0].offsetWidth > 0 && answersshow[0].offsetHeight > 0) {
    answersshow[0].style.visibility = "visible";
  }
}

function bugsshow() {
  var bugsshow = document.getElementsByClassName("bugsshow");
  // Emulates jQuery $(element).is(':hidden');
  if (bugsshow[0].offsetWidth > 0 && bugsshow[0].offsetHeight > 0) {
    bugsshow[0].style.visibility = "visible";
  }
}

function creditsshow() {
  var creditsshow = document.getElementsByClassName("creditsshow");
  // Emulates jQuery $(element).is(':hidden');
  if (creditsshow[0].offsetWidth > 0 && creditsshow[0].offsetHeight > 0) {
    creditsshow[0].style.visibility = "visible";
  }
}
