function scenarioshowserver() {
  var hid = document.getElementsByClassName("scenarioshow-server");
  // Emulates jQuery $(element).is(':hidden');
  if (hid[0].offsetWidth > 0 && hid[0].offsetHeight > 0) {
    hid[0].style.visibility = "visible";
    var statsdel = document.getElementsByClassName("statsshow-server");
    statsdel[0].style.visibility = "hidden";
  }
}

function scendelserver() {
  var scendel = document.getElementsByClassName("scenarioshow-server");
  scendel[0].style.visibility = "hidden";
}

function statsdelserver() {
  var statsdel = document.getElementsByClassName("statsshow-server");
  statsdel[0].style.visibility = "hidden";
}

function ansdelserver() {
  var ansdel = document.getElementsByClassName("answersshow-server");
  ansdel[0].style.visibility = "hidden";
}

function bugsdelserver() {
  var bugsdel = document.getElementsByClassName("bugsshow-server");
  bugsdel[0].style.visibility = "hidden";
}

function creddelserver() {
  var creddel = document.getElementsByClassName("creditsshow-server");
  creddel[0].style.visibility = "hidden";
}

function statsshowserver() {
  var statsshow = document.getElementsByClassName("statsshow-server");
  // Emulates jQuery $(element).is(':hidden');
  if (statsshow[0].offsetWidth > 0 && statsshow[0].offsetHeight > 0) {
    statsshow[0].style.visibility = "visible";
  }
}

function answersshowserver() {
  var answersshow = document.getElementsByClassName("answersshow-server");
  // Emulates jQuery $(element).is(':hidden');
  if (answersshow[0].offsetWidth > 0 && answersshow[0].offsetHeight > 0) {
    answersshow[0].style.visibility = "visible";
  }
}

function bugsshowserver() {
  var bugsshow = document.getElementsByClassName("bugsshow-server");
  // Emulates jQuery $(element).is(':hidden');
  if (bugsshow[0].offsetWidth > 0 && bugsshow[0].offsetHeight > 0) {
    bugsshow[0].style.visibility = "visible";
  }
}

function creditsshowserver() {
  var creditsshow = document.getElementsByClassName("creditsshow-server");
  // Emulates jQuery $(element).is(':hidden');
  if (creditsshow[0].offsetWidth > 0 && creditsshow[0].offsetHeight > 0) {
    creditsshow[0].style.visibility = "visible";
  }
}
