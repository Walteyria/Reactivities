<script>
    import {Button, ButtonGroup, Card, CardBody, CardHeader, CardTitle} from "sveltestrap";
    import {
        activitiesList,
        activityEditMode,
        selectedActivity,
        setSelectedActivity
    } from "../../../app/stores/ActivityStores.js";
    import agent from "../../../app/api/agent.js";
    import LoadingComponent from "../../../app/layout/LoadingComponent.svelte";
    import {Link, Router} from "svelte-routing";


    export let location;
    export let id;
    
    $:if(id){
        if($activitiesList.length >= 1)
            setSelectedActivity($activitiesList.find(x => x.id === id));
        else {
            agent.Activities.details(id).then(response =>{
                if (response)
                    setSelectedActivity(response);
            });
        }
    }
        
</script>

{#if $selectedActivity !== undefined}
    <Card class="mb-4">
        <CardHeader class="p-0">
            <img class="w-100 rounded-top" src="/categoryImages/{$selectedActivity.category}.jpg" alt="Category image"/>
            <CardTitle class="pt-3 px-4 font-weight-bold">{$selectedActivity.title}</CardTitle>
        </CardHeader>
        <CardBody>
            <p class="text-secondary">{$selectedActivity.date}</p>
            <p>{$selectedActivity.description}</p>
            <div class="row px-3 pt-3">
                <Router>
                    <ButtonGroup class="w-100">
                        <Link to="/manage/{id}">
                            <Button outline color="primary">Edit</Button>
                        </Link>
                        <Link to="/activities">
                            <Button class="ml-3" outline color="secondary">Cancel</Button>
                        </Link>
                    </ButtonGroup>
                </Router>
            </div>
        </CardBody>
    </Card>
{:else }
    <LoadingComponent/>
{/if}
<style>
    p{
        margin: 0.3rem;
    }
</style>