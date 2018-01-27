![FilterLists](https://github.com/collinbarrett/FilterLists/blob/master/imgs/logo_filterlists.png)

[![Website](https://img.shields.io/website-up-down-green-red/http/shields.io.svg)](https://filterlists.com/)
[![Travis](https://img.shields.io/travis/collinbarrett/FilterLists.svg?label=travis)](https://travis-ci.org/collinbarrett/FilterLists)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/collinbarrett/FilterLists/blob/master/LICENSE)

[filterlists.com](https://filterlists.com)

FilterLists is the independent and comprehensive directory of all public filter and hosts lists for advertisements, trackers, malware, and annoyances. For more information on its purpose and function, check out [About](https://filterlists.com/about/).

## Links
| Site                                                | API                                               |
| --------------------------------------------------- | ------------------------------------------------- |
| [v3 (Alpha)](https://beta.filterlists.com/)         | [v1 (Alpha)](https://api.filterlists.com/docs)    |
| [v2 (Stable, Frozen)](https://filterlists.com/)     |                                                   |
| [v1 (Legacy, Frozen)](https://v1.filterlists.com/)  |                                                   |

## Submitting or Updating Lists

To suggest a new list or update the information of an existing list, create a PR against [data](https://github.com/collinbarrett/FilterLists/tree/master/data) or open a new [Issue](https://github.com/collinbarrett/FilterLists/issues). Provide all of the information in the Properties section below that is available.

## Development Notice (Updated January 27, 2018)
FilterLists improvements are slow and tend to be in spurts. I care about this project as both a resource for the community and a learning tool for me. However, my day job comes first which often results in little to no work on the project at times. I happily welcome anyone that wants to contribute.

The immediate projects are converting the data to an actual web application (rather than Google Sheets & WordPress), and then exposing the data via a .Net Core API.

### Help Wanted

- Updating the [data](https://github.com/collinbarrett/FilterLists/tree/master/data)
- Building the new API-driven front-end ([FilterLists.Web](https://github.com/collinbarrett/FilterLists/tree/master/src/FilterLists.Web)). The current early direction is [ReactJS](https://reactjs.org/) with [ANT](https://ant.design/) controls. I am not a front-end developer, so I would happily welcome any assistance.

## Properties
*Asterisks indicate a foreign key relationship.

### FilterLists

| Property             | Description                                                              |
|----------------------|--------------------------------------------------------------------------|
| Description          | The list's functionality                                                 |
| DescriptionSourceUrl | The list's Description source URL if quoted directly                     |
| DiscontinuedDate     | The list's date of discontinuation as expressed by the maintainer        |
| DonateUrl            | The list's donation URL                                                  |
| EmailAddress         | The list's email address                                                 |
| ForumUrl             | The list's forum URL                                                     |
| HomeUrl              | The list's home page URL                                                 |
| IssuesUrl            | The list's GitHub Issues URL                                             |
| *Languages           | The list's target languages                                              |
| *License             | The list's license (typically [CC](https://creativecommons.org/choose/)) |
| *Maintainers         | The list's maintainers                                                   |
| Name                 | The list's name (APA Title Case)                                         |
| SubmissionUrl        | The list's submission form URL                                           |
| *Syntax              | The list's syntax (uBlock Origin, Adblock Plus, hosts, etc.)             |
| *UpstreamFilterLists | The list's upstream lists if it is a fork or a merge                     |
| ViewUrl              | The list's view/download URL (typically .txt file)                       |

### Maintainers

| Property      | Description                                |
|---------------|--------------------------------------------|
| EmailAddress  | The maintainer's email address             |
| HomeUrl       | The maintainer's home page URL             |
| Name          | The maintainer's name                      |
| TwitterHandle | The maintainer's Twitter handle            |
| *FilterLists  | The maintainer's lists                     |