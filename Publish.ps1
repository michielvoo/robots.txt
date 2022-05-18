Register-PSRepository `
    -Name MyGet `
    -PublishLocation https://www.myget.org/F/michielvoo/api/v2/package `
    -SourceLocation https://www.myget.org/F/michielvoo/api/v2

Publish-Module `
    -NuGetApiKey $Env:NUGET_API_KEY `
    -Path ./robots.txt/ `
    -Repository MyGet
