<script>
    import {Card, CardBody, CardHeader, CardTitle, Button, CardText, Badge} from "sveltestrap";
    import {activitiesList} from "../../../app/stores/ActivityStores.js";
    import agent from "../../../app/api/agent.js";
    import {Link, Router} from "svelte-routing";

    function deleteActivity(id){
        agent.Activities.delete(id).then(() => {
            $activitiesList = [...$activitiesList.filter(x => x.id !== id)];
        });
    }
    
    export let activity;
</script>

<Card class="mb-3">
    <CardHeader>
        <div class="row">
            <div class="col-7">
                <CardTitle class="font-weight-bold">{activity.title}</CardTitle>
            </div>
            <div class="col text-right">
                <Button on:click={() => deleteActivity(activity.id)} color="danger">Delete</Button>
                <Router>
                    <Link to="/activities/{activity.id}">
                        <Button color="primary">View</Button>
                    </Link>
                </Router>
            </div>
        </div>
    </CardHeader>
    <CardBody class="py-3">
        <CardText>
            <p class="text-secondary">{activity.date}</p>
            <p>{activity.description}</p>
            <p>{activity.city}</p>
            <h4>
                <Badge color="secondary text-white">{activity.category}</Badge>
            </h4>
        </CardText>
    </CardBody>
</Card>