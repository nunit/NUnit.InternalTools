# Get Changes
A minimal projects to list all closed issues in GitHub repository by milestone in Markdown format. Right now, it is designed to create the changelist for NUnit.

## Building ##

In order to build, you must set the GitHub authentication token in `TOKEN` in `Secrets.cs`. Do not check this change in. You can hide the changes to `Secrets.cs` from git by running,

```
git update-index --assume-unchanged GetChanges/Secrets.cs
```

The token is a Personal Access Token which logs you into your GitHub account.

1. Visit the following URL: https://github.com/settings/tokens/new
2. Enter a description in the Token description field, like "GetChanges token".
3. Select the `Repo` scope.
4. Click Create Token.
5. Your new Personal Access token will be displayed.
6. Copy this token, and enter it as the `TOKEN` string.

If you ever want to revoke the token, visit the GitHub Applications settings page and click Delete next to the key you wish to remove.