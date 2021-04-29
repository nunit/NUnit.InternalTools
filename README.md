# Get Changes
A minimal projects to list all closed issues in GitHub repository by milestone in Markdown format. Right now, it is designed to create the changelist for NUnit.

## Configuration ##

In order to run, you must set the GitHub authentication token. This token is a Personal Access Token which logs you into your GitHub account.

1. Visit the following URL: https://github.com/settings/tokens/new
2. Enter a description in the Token description field, like "GetChanges token".
3. Select the `Repo` scope.
4. Click Create Token.
5. Your new Personal Access token will be displayed, copy it
6. If running for the first time, the program will prompt for the token, otherwise to update the token, run with `--configure`

If you ever want to revoke the token, visit the GitHub Applications settings page and click Delete next to the key you wish to remove.