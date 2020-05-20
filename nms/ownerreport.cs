@import url(https://fonts.googleapis.com/css?family=EB+Garamond:300,400,600,700|Open+Sans:300,400,700);
.ui-header.ui-bar-inherit {
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.3);
}

.rb-header:before {
  content: "Demo Company | Demo Location";
  color: #717071;
  text-shadow: none;
  text-align: center;
  text-transform: uppercase;
  width: 100%;
  display: block;
  position: relative;
  top: calc(50% - 12px);
  font-family: "EB Garamond", serif;
  font-weight: 400;
  font-size: 18px;
  letter-spacing: 0.125em;
}

@media (max-width: 600px) {
  .rb-header:before {
    top: calc(50%);
    font-size: 18px;
  }
}
@media (max-width: 250px) {
  .rb-header:before {
    font-size: 14px;
  }

  .ui-header.ui-bar-inherit {
    height: 120px !important;
  }
}
.rb-footer:before {
  background: linear-gradient(to bottom, #f9faf9, rgba(0, 0, 0, 0)), url(https://c1.staticflickr.com/2/1589/25491089481_ce179e5b14_b.jpg) 50% 50% no-repeat, linear-gradient(to bottom, #f9faf9, rgba(0, 0, 0, 0));
  background-size: cover;
  height: 120px;
  display: block;
  content: "";
}

.rb-footer {
  border-top: none;
}

#base_page\:locform\:languageSelect_input-button {
  -webkit-box-shadow: none;
  -moz-box-shadow: none;
  box-shadow: none;
}

#base_page\:locform\:languageSelect_input-button span {
  color: #b6b6b6 !important;
  -webkit-transition: ease-in-out 200ms;
  transition: ease-in-out 200ms;
}

#base_page\:locform\:languageSelect_input-button:hover span {
  color: #fff !important;
}

.ui-panel-m-titlebar.ui-bar.ui-bar-inherit h3, a, .ui-select div, button {
  font-weight: 400 !important;
}

#base_page\:statementExtentMenu\:currentBalance {
  font-weight: 600 !important;
}

a, .ui-select {
  text-transform: uppercase !important;
  letter-spacing: 0.125em;
}

.ui-panel-m-content.ui-body.ui-body-inherit {
  font-weight: 300;
}

.ui-panel-m-titlebar.ui-bar.ui-bar-inherit {
  background-color: #282828 !important;
}

.ui-panel-m-titlebar.ui-bar.ui-bar-inherit h3 {
  font-family: "EB Garamond", serif !important;
  color: #f9f9f9 !important;
  font-size: 1.5rem !important;
  font-weight: 300 !important;
  text-align: center;
  width: 100%;
}

#base_page\:messagePanel .ui-panel-m-titlebar.ui-bar.ui-bar-inherit {
  font-family: "EB Garamond", serif !important;
  font-size: 1.5rem !important;
  font-weight: 300 !important;
  background-color: #717071 !important;
}

#base_page\:messagePanel .ui-panel-m-titlebar.ui-bar.ui-bar-inherit h3 {
  color: #333 !important;
  font-weight: 600 !important;
}

/* Import font */
body, .ui-collapsible-themed-content:not(.ui-collapsible-collapsed) > .ui-collapsible-heading a, .ui-collapsible-inset .ui-collapsible-heading .ui-btn {
  font-family: "Open Sans", sans-serif;
  background: #aaa;
  text-shadow: none;
  color: #717071;
  -webkit-transition: ease-in-out 200ms;
  transition: ease-in-out 200ms;
}
body:hover, .ui-collapsible-themed-content:not(.ui-collapsible-collapsed) > .ui-collapsible-heading a:hover, .ui-collapsible-inset .ui-collapsible-heading .ui-btn:hover {
  background: #919191;
}


/* Header bar */
.ui-header.ui-bar-inherit {
  background: #282828 no-repeat center;
  background-size: 100px, cover, cover;
  border: none;
  height: 54px;
}

@media (max-width: 600px) {
  .ui-header.ui-bar-inherit {
    height: 104px;
    background-position: center 75%;
  }
}
/* Hide Default Header */
.ui-header.ui-bar-inherit h1.ui-title {
  display: none;
}

/* Input highlights */
.ui-page-theme-a .ui-btn:focus, html .ui-bar-a .ui-btn:focus, html .ui-body-a .ui-btn:focus, html body .ui-group-theme-a .ui-btn:focus, html head + body .ui-btn.ui-btn-a:focus, .ui-page-theme-a .ui-focus, html .ui-bar-a .ui-focus, html .ui-body-a .ui-focus, html body .ui-group-theme-a .ui-focus, html head + body .ui-btn-a.ui-focus, html head + body .ui-body-a.ui-focus {
  -webkit-box-shadow: inset 0 0 4px #aaa !important;
  box-shadow: inset 0 0 4px #aaa !important;
}

/* Non-Accordion Panels */
.ui-panel-m-titlebar.ui-bar.ui-bar-inherit {
  background: #aaa;
  color: #fff;
  font-family: "Open Sans", sans-serif;
  text-shadow: none;
}

.ui-body-a, .ui-page-theme-a .ui-body-inherit, html .ui-bar-a .ui-body-inherit, html .ui-body-a .ui-body-inherit, html body .ui-group-theme-a .ui-body-inherit, html .ui-panel-page-container-a {
  color: #5c5a5a !important;
}

/* Request Panel */
[id*=requestPanel] .ui-panel-m-titlebar.ui-bar.ui-bar-inherit {
  background-color: #e0e0e0 !important;
  color: #5c5a5a !important;
}

/* Icon and header colors */
.rb-avail-roomtype, .ui-column-title, .fa-user:before, .fa-bed:before, .fa-bath:before, #base_page\:vform\:customertable .ui-grid-a {
  color: #292828 !important;
}

.fa:before {
  font-weight: 400;
}

.rbn-datecontrol-button, select, .ui-btn {
  font-family: "Open Sans", sans-serif;
}
.rbn-datecontrol-button:before, select:before, .ui-btn:before {
  font-family: "FontAwesome";
}

/* Date control padding */
.ui-grid-c {
  padding: 0 4px !important;
}
.ui-grid-c .ui-block-a, .ui-grid-c .ui-block-b, .ui-grid-c .ui-block-c, .ui-grid-c .ui-block-d {
  padding: 4px 4px;
}

/* Customer form padding */
#base_page\:vform\:requestPanel > div > .ui-block-a > div > div.ui-panel-m-content {
  padding: 0;
}

#base_page\:vform\:requestPanel div.ui-input-text.ui-body-inherit.ui-corner-all.ui-shadow-inset {
  margin-top: 0.5em;
}

/* About you form padding */
#base_page\:vform\:customertable .ui-block-a {
  padding: 0.5em 0.5em 0.5em 1em;
}
@media (max-width: 560px) {
  #base_page\:vform\:customertable .ui-block-a {
    padding: 0.5em 1em;
  }
}
#base_page\:vform\:customertable .ui-block-b {
  padding: 0.5em 1em 0.5em 0.5em;
}
@media (max-width: 560px) {
  #base_page\:vform\:customertable .ui-block-b {
    padding: 0.5em 1em;
  }
}

/* Enquiry button colour */
.rbn-sendenquiry-button, #base_page\:locform\:currencySelect_input-button, #base_page\:locform\:languageSelect_input-button, #base_page\:back,
#base_page\:backButton, #base_page\:neworderform\:saveorderbutt, #base_page\:resultsform\:vform\:but, #base_page\:neworderform\:addItemsLink, #base_page\:selectvendorform\:searchButton {
  background-color: #282828 !important;
  font-family: "Open Sans", sans-serif !important;
  color: #fff !important;
  border-radius: 5px !important;
  border: 1px solid rgba(0, 0, 0, 0) !important;
  text-transform: none;
  font-weight: 400 !important;
  text-shadow: none !important;
}
.rbn-sendenquiry-button:hover, #base_page\:locform\:currencySelect_input-button:hover, #base_page\:locform\:languageSelect_input-button:hover, #base_page\:back:hover,
#base_page\:backButton:hover, #base_page\:neworderform\:saveorderbutt:hover, #base_page\:resultsform\:vform\:but:hover, #base_page\:neworderform\:addItemsLink:hover, #base_page\:selectvendorform\:searchButton:hover {
  background-color: #353535 !important;
}

/* Book and Pay button colour */
#base_page\:vform\:reservationConditionButt, #base_page\:searchform\:searchButton, #base_page\:vform\:searchButton, #base_page\:resultsform\:vform\:booknpay,
.ui-btn.ui-input-btn, .fa-file-excel-o.ui-btn, .rbn-more-info-button {
  background-color: #282828 !important;
  font-family: "Open Sans", sans-serif !important;
  color: #fff !important;
  border-radius: 5px !important;
  border: 1px solid rgba(0, 0, 0, 0) !important;
  text-transform: none;
  font-weight: 400 !important;
  text-shadow: none !important;
}
#base_page\:vform\:reservationConditionButt:hover, #base_page\:searchform\:searchButton:hover, #base_page\:vform\:searchButton:hover, #base_page\:resultsform\:vform\:booknpay:hover,
.ui-btn.ui-input-btn:hover, .fa-file-excel-o.ui-btn:hover, .rbn-more-info-button:hover {
  background-color: #353535 !important;
}

button.ui-btn, #base_page\:locform\:currencySelect_input-button,
#base_page\:locform\:languageSelect_input-button {
  text-shadow: none !important;
  -webkit-transition: ease-in-out 200ms;
  transition: ease-in-out 200ms;
}

#base_page\:locform\:currencySelect > .ui-select,
#base_page\:locform\:languageSelect > .ui-select {
  margin: 1em 0.175em;
}

#base_page\:locform > .ui-btn-right {
  right: -0.2em !important;
}

/* Vendor padding */
.ui-grid.ui-grid-responsive.rbn-vendor-box {
  padding: 0.5em !important;
}

/* Select Dates Padding */
[id*=date-select-pan] > div.ui-panel-m-content.ui-body.ui-body-inherit {
  padding: 0.5em !important;
  outline: none !important;
  text-shadow: none !important;
  box-shadow: none !important;
}

[id*=date-select-pan] > div > div > .ui-block-a {
  padding-right: 0.5em;
}

[id*=date-select-pan] > div > div > .ui-block-c {
  padding-left: 0.5em;
}

/* Select Dates Mobile */
@media (max-width: 400px) {
  [id*=date-select-pan] > div > div > .ui-block-a {
    padding: 0.25em;
    width: 100%;
  }

  [id*=date-select-pan] > div > div > .ui-block-b {
    padding: 0.25em;
    width: 60%;
  }

  [id*=date-select-pan] > div > div > .ui-block-c {
    padding: 0.25em;
    width: 40%;
  }
}
.ui-page-theme-a {
  background-color: #f9f9f9;
}

#base_page\:vform\:avgridpan > div > div > .ui-grid-c .ui-btn-icon-left {
  padding-left: 1em;
}
#base_page\:vform\:avgridpan > div > div > .ui-grid-c .ui-btn-icon-left:after {
  display: none;
}

#base_page\:vform\:quickbookingtable_data > tr > td > div > div:nth-child(3) > table > tbody > tr > td {
  clear: none;
  display: table-cell;
  width: auto;
}

/* Paginator */
.ui-page-theme-a .ui-btn.ui-btn-active, html .ui-bar-a .ui-btn.ui-btn-active {
  background-color: #5c5a5a;
  border-color: #4f4d4d;
}

/* Gallery */
[id*=gallery] {
  width: 100% !important;
  max-width: 1100px;
  height: auto !important;
}

[id*=fadeEffectImages] {
  width: calc(100vw - 34px) !important;
  max-width: 100% !important;
  max-height: 800px !important;
  height: auto !important;
}

/* L */
@media (min-width: 1100px) {
  [id*=gallery] {
    height: 490px !important;
    max-height: 490px !important;
    min-height: 490px !important;
  }
}
/* M */
@media (min-width: 641px) {
  [id*=gallery] {
    width: 100% !important;
    min-height: 43vw;
    height: auto !important;
  }
}
/* S */
@media (max-width: 640px) {
  [id*=gallery] {
    width: 100% !important;
    min-height: 42vw;
    height: auto !important;
  }
}
.rb-page > .rb-content > div > div:nth-child(2) > .ui-collapsible-content {
  background-color: #f9f9f9;
}

/* Vendor Image */
.rbn-vendor-grid-img {
  height: 100%;
  width: 100%;
}

@media (min-width: 641px) {
  .rbn-vendor-grid-img-col {
    padding-right: 1em;
  }
}
/* Paginator */
.ui-page-theme-a .ui-btn.ui-btn-active, html .ui-bar-a .ui-btn.ui-btn-active {
  background-color: #CB7C86;
  border-color: #CB7C86;
  color: #fff !important;
}

.fa-file-excel-o.ui-btn, #base_page\:periodselectorform\:gotobutt {
  background-color: #CB7C86 !important;
  color: #fff;
  border: none !important;
}

.fa-file-excel-o.ui-btn:hover, #base_page\:periodselectorform\:gotobutt:hover {
  background-color: #884444 !important;
}

i, b, #base_page\:statementExtentMenu\:overviewGrid .ui-block-b,
#base_page\:statementExtentMenu\:overviewPanel p,
#base_page\:statementExtentMenu\:occupiedNightsPanel p,
tbody > tr > td {
  font-weight: 400 !important;
}

tbody > tr > td li {
  font-weight: 300 !important;
}

.rbn-footer {
  display: none;
}
