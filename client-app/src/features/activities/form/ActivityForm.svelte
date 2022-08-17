<script>
    import {Button, Card, Form, Input} from "sveltestrap";
    import {activityEditMode} from "../../../app/layout/stores/ActivityStores.js";
    
    function cancelFormClicked(){
        activityEditMode.set(false);
    }
</script>

<Card>
    <Form class="p-2">
        <Input class="my-2" placeholder="Title"/>
        <Input class="my-2" placeholder="Description" type="textarea"/>
        <Input class="my-2" placeholder="Category"/>
        <Input class="my-2" placeholder="Date"/>
        <Input class="my-2" placeholder="City"/>
        <Input class="my-2" placeholder="Venue"/>
        <div class="col text-right pr-0">
            <Button on:click={cancelFormClicked} class="mr-1" color="secondary" type="submit">Cancel</Button>
            <Button class="ml-1" color="success" type="submit">Submit</Button>
        </div>
    </Form>
</Card>

<style>
    
</style>
    
