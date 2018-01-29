var getItems = function (page) {
    var start = page * tilePerPage;
    var end = start + self.tilePerPage;
    var items = [];
    for (var i = start; i < end; i++) {
        console.log(self.contentItems[i]);
        var div = '<div class="' + self.tileClasses + '">' + self.contentItems[i] + '</div>';
        items.push(div);
    }

    return items;
}

var appendToDocument = function (items) {
    var container = $('#' + self.containerId)
    container.innerHtml = '';
    container.append(items);
}

var paging = function (page) {
    var items = getItems(page);
    appendToDocument(items);
}

var init = function () {
    if (containerId != null) {
        self = {
            contentItems: JSON.parse(contentItems), // global in View file
            containerId: containerId, // global in View file
            tilePerPage: tilePerPage, // global in View file
            paginationId: paginationId,
            tileClasses: tileClasses
        }

        paging(0);

        $('#' + self.paginationId).on('click', 'a', function () {
            paging($(this).innerText);
        });
    }
}

