<script>
    import {Card, CardBody, CardHeader, CardTitle, Button, CardText, Badge} from "sveltestrap";
    export let activities;
    export let selectedActivity = undefined;

    function viewDetailClick(id) {
        selectedActivity=activities.find(x => x.id === id);
        console.log(selectedActivity);
    }
</script>

{#each activities as activity}
    <Card class="mb-3">
        <CardHeader>
            <div class="row">
                <div class="col-7">
                    <CardTitle class="font-weight-bold">{activity.title}</CardTitle>
                </div>
                <div class="col text-right">
                    <Button on:click={() => viewDetailClick(activity.id)} color="primary">View</Button>
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
{/each}

<style>
    p{
        margin: 0.3rem;
    }
</style>