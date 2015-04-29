function getSearchResult(data) {
    var tableRef = document.getElementById('table');
    var newRow = tableRef.insertRow(tableRef.rows.length);
    for(element in data)
    {
        var newRow = tableRef.insertRow(tableRef.rows.length);
        var newcell1 = newRow.insertCell(0);
        newcell.appendChild(document.createTextNode(element.bikeid))

        var newcell2 = newRow.insertCell(1);
        newcell.appendChild(document.createTextNode(element.regnumber))

        var newcell2 = newRow.insertCell(2);
        newcell.appendChild(document.createTextNode(element.producer))

        var newcell2 = newRow.insertCell(3);
        newcell.appendChild(document.createTextNode(element.model))

        var newcell2 = newRow.insertCell(4);
        newcell.appendChild(document.createTextNode(element.colour))
      
       
    }
}