<script>
    import {Button, ButtonGroup, Card, CardBody, CardHeader, CardTitle} from "sveltestrap";
    import {activityEditMode, selectedActivity} from "../../../app/layout/stores/ActivityStores.js";

    function cancelDetailClicked() {
        $selectedActivity = undefined;
    }
    function editDetailClicked() {
        activityEditMode.set(true);
    }
</script>

<Card class="mb-4">
    <CardHeader class="p-0">
        <img class="w-100 rounded-top" src="/categoryImages/{$selectedActivity.category}.jpg" alt="Category image"/>
        <CardTitle class="pt-3 px-4 font-weight-bold">{$selectedActivity.title}</CardTitle>
    </CardHeader>
    <CardBody>
        <p class="text-secondary">{$selectedActivity.title}</p>
        <p>{$selectedActivity.description}</p>
        <div class="row px-3 pt-3">
            <ButtonGroup class="w-100">
                <Button on:click={editDetailClicked} outline class="col-6" color="primary">Edit</Button>
                <Button on:click={cancelDetailClicked} outline class="col-6" color="secondary">Cancel</Button>
            </ButtonGroup>
        </div>
    </CardBody>
</Card>

<style>
    p{
        margin: 0.3rem;
    }
</style>