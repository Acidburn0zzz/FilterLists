function GenerateHtmlAddLink(url, listName) {
    if (url instanceof Array) {
        for (i in url) {
            url[i] = GenerateHtmlAddLink(url[i], listName[i]);
        }
        return url;
    } else {
        if (url && url != "#N/A") {
            var html = "<a href=\"abp:subscribe?location=" + url + "&title=" + listName + "\" title=\"Subscribe to " + listName + " in your content blocker.\" class=\"button piwik_download\">Add</a>";
            return html;
        } else {
            return "";
        }
    }
}