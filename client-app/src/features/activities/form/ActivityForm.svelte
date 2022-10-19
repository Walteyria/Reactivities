<script>
    import {Button, Card, Input} from "sveltestrap";
    import {
        selectedActivity,
        setSelectedActivity,
        activitiesList
    } from "../../../app/stores/ActivityStores.js";
    import { v4 as uuidv4 } from 'uuid';
    import agent from "../../../app/api/agent.js";
    import { navigate } from "svelte-routing";

    export let id;
    
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

    if(id){
        if($activitiesList.length >= 1)
            setSelectedActivity($activitiesList.find(x => x.id === id));
        else {
            agent.Activities.details(id).then(response =>{
                if (response)
                    setSelectedActivity(response);
            });
        }
    }
    else 
        $selectedActivity = undefined;
    
    $:if ($selectedActivity)
        activityForm = $selectedActivity;
    else
        setActivityEmptyForCreate();
        

    function cancelFormClicked(){
        
    }
    
    function submitFormClicked(){
        if (activityForm.id)
            updateActivity(activityForm);
        else
            createActivity(activityForm);
    }
    
    function updateActivity(activity){
        setSelectedActivity(activity);
        agent.Activities.update(activity).then(() => {
            $activitiesList = [...$activitiesList.filter(x => x.id !== activity.id),activity];
        });
        navigate("/activities/"+activity.id);
    }
     
    function createActivity(activity){
        activity.id = uuidv4();
        setSelectedActivity(activity);
        agent.Activities.create(activity).then(() => {
            $activitiesList = [...$activitiesList,activity];
        });
        navigate("/activities/"+activity.id);
    }

    export let location;
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
    
