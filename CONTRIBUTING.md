# How to contribute

We like to encourage you to contribute to the repository.
This should be as easy as possible for you but there are a few things to consider when contributing.
The following guidelines for contribution should be followed if you want to submit a pull request.

## How to prepare

* You need a [GitHub account](https://github.com/signup/free)
* Submit an [issue ticket](https://github.com/Codeusa/Borderless-Gaming/issues) for your issue if no one has done so yet.
	* Describe the issue and include steps to reproduce if it's a bug.
	* Ensure to mention the earliest version that you know is affected.
* If you are able and want to fix this, fork the repository on GitHub

## Make Changes

* In your forked repository, create a topic branch for your upcoming patch. (e.g. `better favorites detection` or `failed-to-edit-window-fix`)
	* Usually this is based on the master branch.
	* Create a branch based on master; `git branch
	fix/master/my_contribution master` then checkout the new branch with `git
	checkout fix/master/my_contribution`.  Please avoid working directly on the `master` branch.
* Make sure you stick to the coding style that is used already.
* Make commits of logical units and describe them properly.
* Syntax:
    * Two spaces, no tabs.
    * No trailing whitespace. Blank lines should not have any space.
    * a = b and not a=b.
    * Follow the conventions you see used in the source already.

## Submit Changes

* Push your changes to a topic branch in your fork of the repository.
* Open a pull request to the original repository and choose the right original branch you want to patch.
* If not done in commit messages (which you really should do) please reference and update your issue with the code changes. But _please do not close the issue yourself_.
* Even if you have write access to the repository, do not directly push or merge pull-requests. Let another team member review your pull request and approve.

# Additional Resources

* [General GitHub documentation](http://help.github.com/)
* [GitHub pull request documentation](http://help.github.com/send-pull-requests/)