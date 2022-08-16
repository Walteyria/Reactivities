<script>
    import {Button, ButtonGroup, Card, CardBody, CardHeader, CardTitle} from "sveltestrap";
    export let activity;
</script>

<Card class="mb-4">
    <CardHeader class="p-0">
        <img class="w-100 rounded-top" src="/categoryImages/{activity.category}.jpg" alt="Category image"/>
        <CardTitle class="pt-3 px-4 font-weight-bold">{activity.title}</CardTitle>
    </CardHeader>
    <CardBody>
        <p class="text-secondary">{activity.title}</p>
        <p>{activity.description}</p>
        <div class="row px-3 pt-3">
            <ButtonGroup class="w-100">
                <Button outline class="col-6" color="primary">Edit</Button>
                <Button outline class="col-6" color="secondary">Cancel</Button>
            </ButtonGroup>
        </div>
    </CardBody>
</Card>

<style>
    p{
        margin: 0.3rem;
    }
</style>