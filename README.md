# MaintenanceProject
ISYS 4363 Maintenance Project

###Getting Started
To get familiar with GitHub, please follow this guide:
[Getting Started](https://guides.github.com/activities/hello-world/) 

It covers the topics:
* Create and use a repository
* Start and manage a new branch
* Make changes to a file and push them to GitHub as commits
* Open and merge a pull request

---
###How to Use With Visual Studio
You are able to use this with Visual Studio. It's already installed on the school computers. Here is an overview of using 
[GitHub with Visual Studio](https://visualstudio.github.com/)

---
###Access the Project from Visual Studio
* Open Visual Studio
* Open the **Team Explorer Window**
* Click the *Clone* option.

<img src="Clone.PNG" width="230" height="200" />
* In the first textbox enter the link to the repository. 
* *https://github.com/AEGriffith/MaintenanceProject*

<img src="LinkToRep.PNG" width="300" height="150" />
* The second box is where it will be located on your computer. 
* Click the *Clone* button. 
* You should get a message saying that the repository was clones successfully.
* You should also be able to see it under your *Local Git Repositories* section.

<img src="SuccessfulLink.PNG" width="300" height="300" />
* Click the Repository.
* You will see this screen.

<img src="OpenScreen.PNG" width="250" height="300" />
* Open the solution file to work on the project.
* *It is very important to take note of the branch you are working on*
* You can see or change the branch you are working on from the bottom right of Visual Studio.

<img src="VSGHBranches.PNG" width="200" height="150" />
* New branches can also be created from here.

---
###Create New Branch

* In the Team Explorer window, select Branches

<img src="SelectBranches.JPG" width="300" height="225" />
* Select Master (**NOTE: DO NOT SELECT the remotes/origin master**)

<img src="SelectMaster.JPG" width="200" height="150" />
  * This can also be done by selecting the master branch from the menu at the bottom of Visual Studio.

* Click the home button.
* Click Sync

<img src="SyncMaster.JPG" width="300" height="300" />
* This is where you will sync the master file on your computer with the one on the server.

<img src="SyncMaster1.JPG" width="200" height="400" />
* This will show all of the updates that have been made. 
* Click Sync

<img src="SyncMaster2.JPG" width="200" height="400" />
* Now you will receive a message indicating the sync was successful.

<img src="SyncMessage.JPG" width="200" height="400" />
* Now you will click branch menu at the bottom. 

<img src="BranchMenu.JPG" width="300" height="50" />
* Click New Branch
* Enter a name for your new branch. (I recommend using your User Story Identification)

<img src="NewBranchName.JPG" width="200" height="400" />
* Select the branch you want to create the branch from. (This will be the master branch you just updated)
* Click Create Branch

Now you are ready to work on your new branch!
* Click the Home button
* Double click the solution file!

<img src="SyncMaster.JPG" width="300" height="300" />

---
###Publish Your Work

* In the home menu of the Team Explorer window, Click Sync.
* Click Publish

<img src="PublishBranch.JPG" width="300" height="300" />
* In the home menu of the Team Explorer window, Click Changes
* Add a comment
* Click Commit All and Push (use the arrow next to the Commit All button)

<img src="Commit.JPG" width="300" height="300" />

* Go to Github.com 
* Select the repository.
* You should see something like this.

<img src="ComparePull.JPG" width="750" height="300" />
* Click the Compare and Pull request button
* Add a comment to give details about the pull request


<img src="CreatePullRequest.JPG" width="500" height="500" />
* Click Create Pull Request
* You should see a screen like this:

<img src="NoConflicts.JPG" width="750" height="300" />
* *If it does not say that it has "no conflicts" with the base branch, please contact Amanda and stop here.*
* Click the Merge Pull Request button
* Add more comments if you feel it is needed.

<img src="MoreComments.JPG" width="750" height="300" />
* Click Confirm merge
* Delete the Branch

<img src="DeleteBranch.JPG" width="500" height="150" />

