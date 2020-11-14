git checkout <existing_branch>

git checkout -b <new_branch>

git status -s

git log --oneline

# merge into master branch
git checkout master
git pull origin master
git merge other-branch
git push origin master
