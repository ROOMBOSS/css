@import url(https://fonts.googleapis.com/css?family=Open+Sans:400,700);
.rbn-tab-img {
  padding-right: .5em; }

/* .ui-collapsible-themed-content:not(.ui-collapsible-collapsed)>.ui-collapsible-heading a,.ui-collapsible-inset .ui-collapsible-heading .ui-btn, */
/*.ui-panel-m-titlebar.ui-bar.ui-bar-inherit, .ui-panel-m-titlebar.ui-bar.ui-bar-inherit h3 { text-transform: uppercase !important; font-weight: 400 !important;}*/
/* Extra color */
#base_page\:vform .table-stripe tbody tr:nth-child(even) td {
  background-color: #ebebf1;
  text-shadow: none !important; }

#base_page\:vform\:rqpnl .ui-panel-m-titlebar {
  background-color: #2f2f2f !important;
  color: white !important; }

#base_page\:vform .table-stripe tbody tr:nth-child(even) .vendor-icons td {
  border: 1px solid #ebebf1;
  background-color: rgba(0, 0, 0, 0.04); }

/*.ui-btn:after {
  background-color: #1a4d1e;
}*/
/* Import font */
body, .ui-collapsible-themed-content:not(.ui-collapsible-collapsed) > .ui-collapsible-heading a, .ui-collapsible-inset .ui-collapsible-heading .ui-btn {
  font-family: "Open Sans", sans-serif;
  background: #242424;
  text-shadow: none;
  color: #fff;
  -webkit-transition: ease-in-out 200ms;
  transition: ease-in-out 200ms; }
  body:hover, .ui-collapsible-themed-content:not(.ui-collapsible-collapsed) > .ui-collapsible-heading a:hover, .ui-collapsible-inset .ui-collapsible-heading .ui-btn:hover {
    background: #0b0b0b; }

/* Header bar */
.ui-header.ui-bar-inherit {
  background: url(HAKULife-N.svg) no-repeat center center;
  background-color: #e3dfdc;
  background-size: 140px;
  border: none;
  height: 180px; }

@media (max-width: 600px) {
  .ui-header.ui-bar-inherit {
    height: 205px;
    background-position: center 75%; } }
/* Hide Default Header */
.ui-header.ui-bar-inherit h1.ui-title {
  display: none; }

/* Input highlights */
.ui-page-theme-a .ui-btn:focus, html .ui-bar-a .ui-btn:focus, html .ui-body-a .ui-btn:focus, html body .ui-group-theme-a .ui-btn:focus, html head + body .ui-btn.ui-btn-a:focus, .ui-page-theme-a .ui-focus, html .ui-bar-a .ui-focus, html .ui-body-a .ui-focus, html body .ui-group-theme-a .ui-focus, html head + body .ui-btn-a.ui-focus, html head + body .ui-body-a.ui-focus {
  -webkit-box-shadow: inset 0 0 4px #aaa !important;
  box-shadow: inset 0 0 4px #aaa !important; }

/* Non-Accordion Panels */
.ui-panel-m-titlebar.ui-bar.ui-bar-inherit {
  background: #242424;
  color: #fff;
  font-family: "Open Sans", sans-serif;
  text-shadow: none; }

.ui-body-a, .ui-page-theme-a .ui-body-inherit, html .ui-bar-a .ui-body-inherit, html .ui-body-a .ui-body-inherit, html body .ui-group-theme-a .ui-body-inherit, html .ui-panel-page-container-a {
  color: #5c5a5a !important; }

/* Request Panel */
[id*="requestPanel"] .ui-panel-m-titlebar.ui-bar.ui-bar-inherit {
  background-color: #e0e0e0 !important;
  color: #5c5a5a !important; }

/* Icon and header colors */
.rb-avail-roomtype, .ui-column-title, .fa-user:before, .fa-bed:before, .fa-bath:before, #base_page\:vform\:customertable .ui-grid-a {
  color: #292828 !important; }

.fa:before {
  font-weight: 400; }

.rbn-datecontrol-button, select, .ui-btn {
  font-family: "Open Sans", sans-serif; }
  .rbn-datecontrol-button:before, select:before, .ui-btn:before {
    font-family: "FontAwesome"; }

/* Date control padding */
.ui-grid-c {
  padding: 0 4px !important; }
  .ui-grid-c .ui-block-a, .ui-grid-c .ui-block-b, .ui-grid-c .ui-block-c, .ui-grid-c .ui-block-d {
    padding: 4px 4px; }

/* Customer form padding */
#base_page\:vform\:requestPanel > div > .ui-block-a > div > div.ui-panel-m-content {
  padding: 0; }

#base_page\:vform\:requestPanel div.ui-input-text.ui-body-inherit.ui-corner-all.ui-shadow-inset {
  margin-top: .5em; }

/* About you form padding */
#base_page\:vform\:customertable .ui-block-a {
  padding: .5em .5em .5em 1em; }
  @media (max-width: 560px) {
    #base_page\:vform\:customertable .ui-block-a {
      padding: .5em 1em; } }
#base_page\:vform\:customertable .ui-block-b {
  padding: .5em 1em .5em .5em; }
  @media (max-width: 560px) {
    #base_page\:vform\:customertable .ui-block-b {
      padding: .5em 1em; } }


#base_page\:locform > .ui-btn-right {
  right: -.2em !important; }

/* Vendor Image */
.rbn-vendor-grid-img {
  height: 100%;
  width: 100%; }

@media (min-width: 641px) {
  .rbn-vendor-grid-img-col {
    padding-right: 1em; } }
/* Cost */
@media (min-width: 561px) {
  td.right {
    float: none;
    text-align: right; } }
.ui-column-header.right {
  border-bottom: none; }

.ui-collapsible-heading-toggle,
.rbn-toggle > div.ui-panel-m-titlebar,
.rbn-notoggle > div.ui-panel-m-titlebar {
  border-color: #333 !important; }


.ui-btn-icon-right:not(#base_page\:locform\:languageSelect_input-button):not(#base_page\:locform\:currencySelect_input-button):after {
  background-color: #BF9F5F; }


.ui-accordion div.ui-collapsible-content.ui-body-inherit {
  border: none; }

.rbn-footer, .rb-footer {
  display: none; }

button.fa-file-excel-o {
  padding-left: 1em; }

button.fa-file-excel-o:after {
  display: none; }

/* Disabled searchform */
#base_page\:resultsform\:sortPanelGrid .ui-state-disabled {
  background-color: #dddddd;
  color: #aaaaaa; }

.ui-checkbox-on:after {
  background-color: #bf9f5f !important; }

.ui-panel-m .ui-panel-m-titlebar {
  border: 1px solid #333; }

/* v-form MA */
#base_page\:resultsform\:vform\:requestPanel .rbn-margin-top {
  border-radius: 5px;
  background-color: #f9f9f9 !important; }

.ui-content .rb-content {
  background-color: #f9f9f9; }
