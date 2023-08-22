let slider = document.getElementById("colorSlider");
let output = document.getElementById("hueValue");
let presetList = document.getElementById("preset-list");
let r = document.querySelector(':root');
output.innerHTML = slider.value; // Display the default slider value

function getColorNode(l, c, h) {
    return new Color("oklch", [l, c, h]).to("srgb").toString({ format: "hex" });
}
function setHue(hue) {
    localStorage.setItem('hue', hue);
    output.innerHTML = hue;
    slider.value = hue;

    r.style.setProperty(`--primary-hue`, hue);
}

let storedHue = localStorage.getItem('hue');
if (storedHue) {
    setHue(storedHue);
}

slider.oninput = function () {
    output.innerHTML = this.value;
    let hue = this.value;
    setHue(hue);
}

presetList.onclick = function (event) {
    let hue = event.target.dataset.hue;
    if (hue) {
        setHue(hue);
    }
}

// Banner switch

function enableBanner() {
    r.setAttribute("showBanner", "true");
    localStorage.setItem('showBanner', "true");
}

function disableBanner() {
    r.setAttribute("showBanner", "false");
    localStorage.setItem('showBanner', "false");
}

let showBannerCheck = document.querySelector("input[name=banner-checkbox]");
if (r.getAttribute("showBanner") === "true") {
    showBannerCheck.checked = true;
}
showBannerCheck.addEventListener('change', function () {
    if (this.checked) {
        enableBanner();
    } else {
        disableBanner();
    }
});

// scroll top
function topFunction() {
    window.scroll({ top: 0, behavior: 'smooth' });
}
let btn = document.getElementById('back-to-top-btn');
function scrollFunction() {
    if (document.body.scrollTop > 600 || document.documentElement.scrollTop > 600) {
        btn.classList.remove('hide')
    } else {
        btn.classList.add('hide')
    }
}
window.onscroll = function () {
    scrollFunction();
}

// theme switch
let themeFunc = async function () {
    let btn = document.getElementById("theme-btn");
    let root = document.documentElement;
    btn.addEventListener('click', e => {
        if (root.getAttribute('theme') == 'dark') {
            root.setAttribute('theme', 'light');
            localStorage.setItem('theme', 'light');
        } else {
            root.setAttribute('theme', 'dark');
            localStorage.setItem('theme', 'dark');
        }
    });
};
themeFunc();