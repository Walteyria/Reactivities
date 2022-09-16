<script>
    import {Button, Card, Input} from "sveltestrap";
    import {
        activityEditMode,
        selectedActivity,
        setSelectedActivity,
        activitiesList
    } from "../../../app/stores/ActivityStores.js";
    import { v4 as uuidv4 } from 'uuid';
    import agent from "../../../app/api/agent.js";
    
    let activityForm = {
        id: "",
        title: "",
        description: "",
        category: "",
        date: "",
        city: "",
        venue: ""
    };
    
    function setActivityEmptyForCreate()
    {
        activityForm.id = "";
        activityForm.title = "";
        activityForm.description = "";
        activityForm.category = "";
        activityForm.date = "";
        activityForm.city = "";
        activityForm.venue = "";
    }
    
    $:if ($selectedActivity)
        activityForm = $selectedActivity;
    else
        setActivityEmptyForCreate();

    function cancelFormClicked(){
        activityEditMode.set(false);
    }
    
    function submitFormClicked(){
        if (activityForm.id)
            updateActivity(activityForm);
        else
            createActivity(activityForm);
    }
    
    function updateActivity(activity){
        activityEditMode.set(false);
        setSelectedActivity(activity);
        agent.Activities.update(activity).then(() => {
            $activitiesList = [...$activitiesList.filter(x => x.id !== activity.id),activity];
        });
    }
    
    function createActivity(activity){
        activity.id = uuidv4();
        activityEditMode.set(false);
        setSelectedActivity(activity);
        agent.Activities.create(activity).then(() => {
            $activitiesList = [...$activitiesList,activity];
        });
    }
</script>

<Card>
    <form class="p-2" on:submit|preventDefault={submitFormClicked}>
        <Input class="my-2" placeholder="Title" bind:value={activityForm.title}/>
        <Input class="my-2" placeholder="Description" type="textarea" bind:value={activityForm.description}/>
        <Input class="my-2" placeholder="Category" bind:value={activityForm.category}/>
        <Input class="my-2" type="date" placeholder="Date" bind:value={activityForm.date}/>
        <Input class="my-2" placeholder="City" bind:value={activityForm.city}/>
        <Input class="my-2" placeholder="Venue" bind:value={activityForm.venue}/>
        <div class="col text-right pr-0">
            <Button on:click={cancelFormClicked} class="mr-1" color="secondary">Cancel</Button>
            <Button class="ml-1" type="submit" color="success">Submit</Button>
        </div>
    </form>
    
</Card>

<style>
    
</style>
    
