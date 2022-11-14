// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var btnXls = document.querySelectorAll('.action button')[0]
var btnCsv = document.querySelectorAll('.action button')[1]
var btnXml = document.querySelectorAll('.action button')[2]


btnXls.onclick = () => exportData('xls')
btnCsv.onclick = () => exportData('csv')
btnXml.onclick = () => exporttoxml()

function exportData(type) {
    const fileName = 'countries-sheet.' + type
    const table = document.getElementById("countriesTable")
    const wb = XLSX.utils.table_to_book(table)
    XLSX.writeFile(wb, fileName)
}