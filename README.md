# Rust Save Lag Reduce
Application to modify plugins and reduce save lag spikes

## How it works and Why save lag spike happens
A lot of servers lagging when map is saving. That happens because a lot of developers using `OnServerSave` hook, but they dont keep in mind that there can be more than 15 plugins using that on same time. 

My tool is replacing all of that hooks with custom ones, and calling data save after map save in 3 seconds for plugin in a list (3s - plugin - 3s - plugin - etc)

## How to use

Step 1: Download last release at [Click on me](https://github.com/OrangeWulf/Rust-Save-Lag-Reduce/releases/latest)

Step 2: Download all your plugins to special folder and add there `RustSaveLagReduce.exe`

Step 3: Run `RustSaveLagReduce.exe`

Step 4: After it finished working reupdate files to your server

Step 5: Download [Plugin](https://rustworkshop.space/resources/save-lag-reduce.229/) that will call manual saving of plugin information
